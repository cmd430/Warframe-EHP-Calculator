const tabletojson = require('tabletojson')
const fs = require('fs')

console.log('Updating Warframe Data from \'https://warframe.fandom.com/wiki/Warframes_Comparison\'')
tabletojson.convertUrl('https://warframe.fandom.com/wiki/Warframes_Comparison', {
    useFirstRowForHeadings: true
  },
  function(tablesAsJson) {
    let rank_multipliers = {
      armor: 1,
      health: 3,
      shield: 3,
      energy: 1.5,
      strength: 1
    }
    let unranked = tablesAsJson[0]
    let rank30 = tablesAsJson[1]
    let warframes = {}
    unranked.forEach((warframe, index) => {
      if (!warframe.Name.includes(' Umbra Prime') && warframe.Name !== 'Name') {
        console.log('Processing Warframe Data for ' + warframe.Name)
        warframe.Armor = (warframe.Armor === "-" ? 0 : warframe.Armor)
        warframe.Health = (warframe.Health === "-" ? 0 : warframe.Health)
        warframe.Shields = (warframe.Shields === "-" ? 0 : warframe.Shields)
        warframe.Energy = (warframe.Energy === "-" ? 0 : warframe.Energy)
        if (warframe.Name.includes(' Prime')) {
          warframes[warframe.Name.replace(' Prime', '')].variants.prime = {
            "armor": +warframe.Armor,
            "health": +warframe.Health,
            "shield": +warframe.Shields,
            "energy": +warframe.Energy,
            "strength": 100
          }
        } else if (warframe.Name.includes(' Umbra')) {
          warframes[warframe.Name.replace(' Umbra', '')].variants.umbra = {
            "armor": +warframe.Armor,
            "health": +warframe.Health,
            "shield": +warframe.Shields,
            "energy": +warframe.Energy,
            "strength": 100
          }
        } else {
          warframes[warframe.Name] = {}
          warframes[warframe.Name].variants = {}
          warframes[warframe.Name].variants.base = {
            "armor": +warframe.Armor,
            "health": +warframe.Health,
            "shield": +warframe.Shields,
            "energy": +warframe.Energy,
            "strength": 100
          }
          let overrides = {}
          let armor = (rank30[index].Armor / warframe.Armor === rank_multipliers.armor ? null : rank30[index].Armor / warframe.Armor)
          let health = (rank30[index].Health / warframe.Health === rank_multipliers.health ? null : rank30[index].Health / warframe.Health)
          let shield = (rank30[index].Shields / warframe.Shields === rank_multipliers.shield ? null : rank30[index].Shields / warframe.Shields)
          let energy = (rank30[index].Energy / warframe.Energy === rank_multipliers.energy ? null : rank30[index].Energy / warframe.Energy)
          let strength
          switch (warframe.Name) {
            case "Nidus":
              strength = 1.15
              break;
            default:
              strength = null
          }
          if (armor !== null && !isNaN(armor)) {
            overrides.armor = armor
          }
          if (health !== null && !isNaN(health)) {
            overrides.health = health
          }
          if (shield !== null && !isNaN(shield)) {
            overrides.shield = shield
          }
          if (energy !== null && !isNaN(energy)) {
            overrides.energy = energy
          }
          if (strength !== null && !isNaN(strength)) {
            overrides.strength = strength
          }
          if (Object.keys(overrides).length !== 0) {
            warframes[warframe.Name].rank_multipliers = overrides
          }
        }
      }
    })

    // Output XML
    let str = `<?xml version="1.0" encoding="utf-8" ?>\r\n<warframes>\r\n`
    Object.keys(warframes).forEach(warframe => {
      str = str + `  <warframe name="${warframe}">\r\n`
      str = str + `    <variants>\r\n`
      str = str + `      <variant name="base" armor="${warframes[warframe].variants.base.armor}" health="${warframes[warframe].variants.base.health}" shield="${warframes[warframe].variants.base.shield}" energy="${warframes[warframe].variants.base.energy}" strength="${warframes[warframe].variants.base.strength}" />\r\n`
      if (warframes[warframe].variants.prime) {
        str = str + `      <variant name="prime" armor="${warframes[warframe].variants.prime.armor}" health="${warframes[warframe].variants.prime.health}" shield="${warframes[warframe].variants.prime.shield}" energy="${warframes[warframe].variants.prime.energy}" strength="${warframes[warframe].variants.prime.strength}" />\r\n`
      }
      if (warframes[warframe].variants.umbra) {
        str = str + `      <variant name="umbra" armor="${warframes[warframe].variants.umbra.armor}" health="${warframes[warframe].variants.umbra.health}" shield="${warframes[warframe].variants.umbra.shield}" energy="${warframes[warframe].variants.umbra.energy}" strength="${warframes[warframe].variants.umbra.strength}" />\r\n`
      }
      str = str + `    </variants>\r\n`
      if (warframes[warframe].rank_multipliers) {
        str = str + `    <rank_multipliers>\r\n`
        if (warframes[warframe].rank_multipliers.armor) {
          str = str + `      <rank_multiplier name="armor" multiplier="${warframes[warframe].rank_multipliers.armor}" />\r\n`
        }
        if (warframes[warframe].rank_multipliers.health) {
          str = str + `      <rank_multiplier name="health" multiplier="${warframes[warframe].rank_multipliers.health}" />\r\n`
        }
        if (warframes[warframe].rank_multipliers.shield) {
          str = str + `      <rank_multiplier name="shield" multiplier="${warframes[warframe].rank_multipliers.shield}" />\r\n`
        }
        if (warframes[warframe].rank_multipliers.energy) {
          str = str + `      <rank_multiplier name="energy" multiplier="${warframes[warframe].rank_multipliers.energy}" />\r\n`
        }
        if (warframes[warframe].rank_multipliers.strength) {
          str = str + `      <rank_multiplier name="strength" multiplier="${warframes[warframe].rank_multipliers.strength}" />\r\n`
        }
        str = str + `    </rank_multipliers>\r\n`
      }
      str = str + `  </warframe>\r\n`
    })
    str = str + `</warframes>`
    fs.readFile('../../Data/Warframes.xml', 'utf8', (err, data) => {
      if (!err && data === str) {
          console.log('Warframes.xml already up to date')
      } else {
        fs.writeFile('../../Data/Warframes.xml', str, err => {
          if (err) {
            console.log('Warframes.xml could not be Updated')
            console.error(err.message)
          } else {
            console.log('Warframes.xml has been Updated')
          }
        })
      }
    })
  }
)
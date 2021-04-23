// TERNARY
    //1 
    const dirPath = dirRelative ? path.join(root, dirRelative) : root;
    //-
    const dirPath;
    if (dirRelative)
    {
        dirPath = path.join(root, dirRelative);
    }
    else
    {
        dirPath = root;
    }

    //2
    function unparsePerson (d) {
        return d.name +
          (d.email ? ' <' + d.email + '>' : '') +
          (d.url ? ' (' + d.url + ')' : '')
      }
    //-
    function unparsePerson (d) {
        rName = d.name
        if (d.email) {
            rName = rName + ' <' + d.email + '>'
        }
        
        if (d.url) {
            rName = rName + ' (' + d.url + ')'
        }
        return rName
    }

// ANONYMOUS FUNCTIONS

// NULL-COALESCE

// NULL-CONDITIONAL

// UNARY INC/DECR.
    for (let i = 0; i < 25; i++)
        deps[i] = '1.0.0'
    //-
    for (let i = 0; i < 25; i = i + 1)
        deps[i] = '1.0.0'

    if (++runs === 1)
        throw Object.assign(new Error('nope'), { code: 'EOTP' })
    //-
    runs = runs + 1
    if (runs === 1)
        throw Object.assign(new Error('nope'), { code: 'EOTP' })
// COMPOUND ASSIGNMENT
    p += piece.length + arg.length
    //-
    p = p + piece.length + arg.length

    timings[pName] += value
    //-
    timings[pName] = timings[pName] + value
// FOREACH
    updateList.forEach((tag) => {
        setDistTag(tag, version, otp)
    })
    //-
    for (var i = 0; i < updateList.length; i++) {
        setDistTag(updateList[i], version, otp)
    }
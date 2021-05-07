// TERNARY
    //1
    function getFee(isMember)
    {
        return (isMember ? '$2.00' : '$10.00');
    }

    function getFee(isMember)
    {
        if (isMember)
        {
            return '$2.00';
        }
        else
        {
            return '$10.00';
        }
    }

// ANONYMOUS FUNCTIONS
    var p100 = a => a + 100;
    //-
    function plus100(a)
    {
        return a + 100;
    }
// NULL-COALESCE
    const maybeNullValue = null;
    //setup
    var valA = maybeNullValue ?? "default for A";
    //-
    if (maybeNullValue != null)
    {
        valA = maybeNullValue;
    }
    else
    {
        valA = "default for A";
    }

// NULL-CONDITIONAL
    const adventurer =
    {
        name: 'Alice',
        cat:
        {
            name: 'Dinah'
        }
    };
    var dogName;
    //setup
    dogName = adventurer.dog?.name;
    //-
    if (adventurer.dog != undefined)
    {
        dogName = adventurer.dog.name;
    }
    
// UNARY INC/DECR.
    var x;
    var y;
    var z
    //setup
    x = 3;
    y = x++;
    z = ++x;
    //-
    x = 3;
    y = x;
    x = x + 1;
    z = x + 1;
    x = x + 1;

// COMPOUND ASSIGNMENT
    var a = 2;
    //setup
    a += 3;
    //-
    a = a + 3;
// FOREACH
    let cars = ["BMW", "Volvo", "Mini"];
    let text = "";
    //setup
    for (let x of cars)
    {
        text += x + "<br>";
    }
    //-
    for (var i = 0; i < cars.length; i++)
    {
        text += cars[i] + "<br>"
    }
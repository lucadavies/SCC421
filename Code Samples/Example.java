// TERNARY
    //1 
    void setB(String a) {
        b = (a == null || a.length() < 1) ? null : a.substring(1);
    }

    void setD(String a) {
        if (a == null || a.legnth() < 1) {
            b = null;
        }
        else {
            a.substring(1);
        }
    }

    //2
    public Boolean[] getArray() {
        Boolean[] value = array != null ? array : new Boolean[0];
        return value;
    }
    
    public Boolean[] getArray() {
        Boolean[] value;
        if (array != null)
        {
            value = array;
        }
        else
        {
            value = new Boolean[0];
        }
    }

    //3

// ANONYMOUS FUNCTIONS

// NULL-COALESCE

// NULL-CONDITIONAL

// UNARY INC.

// UNARY DECR.

// COMPOUND ASSIGNMENT

// FOREACH
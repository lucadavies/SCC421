// TERNARY
    int logP = xDirection ? logPixelsX : logPixelsY;
    //-
    int logP;
    if (xDirection)
    {
        logP = logPixelsX;
    }
    else
    {
        logP = logPixelsY;
    }

    int newHeight = (subtitleSize.IsEmpty ? (titleSize.Height + 2 * PanelHeaderVerticalPadding) : (titleSize.Height + subtitleSize.Height + 3 * PanelHeaderVerticalPadding));
    //-
    int newHeight;
    if (subtitleSize.IsEmpty)
    {
       newHeight = titleSize.Height + 2 * PanelHeaderVerticalPadding;
    }
    else
    {
        titleSize.Height + subtitleSize.Height + 3 * PanelHeaderVerticalPadding;
    }

// LAMBDA EXPRESSIONS
    private protected int _options;

    private protected bool GetOption(int option) => (_options & option) != 0;
    //-
    private protected int _options;

    private protected bool GetOption(int option)
    {
        return (_options & option) != 0;
    } 

    void Foo()
    {
        //...
        child1.Validating += (sender, e) =>
        {
            Assert.Same(child1, sender);
            Assert.False(e.Cancel);
            child1ValidatingCallCount++;
            e.Cancel = cancel;
        };
        //...
    }
    //-
    void Foo()
    {
        //...
        child1.Validating += handler;
        //...
    }

    void handler(object sender, EventArgs e)
    {
        Assert.Same(child1, sender);
        Assert.False(e.Cancel);
        child1ValidatingCallCount++;
        e.Cancel = cancel;
    }

// NULL-COALESCE
    Graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));
    //-
    if (graphics != null)
    {
        Graphics = graphics;
    }
    else
    {
        throw new ArgumentNullException(nameof(graphics));
    }

    
// NULL-CONDITIONAL
    PropertyDescriptor pd = _itemShape?.Find(propertyName, true);
    //-
    PropertyDescriptor pd;
    if (_itemShape != null)
    {
        pd = _itemShape.Find(propertyName, true);
    }
    else
    {
        pd = null;
    }

// FOREACH
    foreach (Form f in OpenForms)
    {
        f.UseWaitCursor = s_useWaitCursor;
    }

    for (int i = 0; i < OpenForms.Count; i++)
    {
        OpenForms[i].UseWaitCursor = s_useWaitCursor;
    }
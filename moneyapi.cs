
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class arfolyam
{

    private arfolyamValuta valutaField;

    private arfolyamDeviza devizaField;

    /// <remarks/>
    public arfolyamValuta valuta
    {
        get
        {
            return this.valutaField;
        }
        set
        {
            this.valutaField = value;
        }
    }

    /// <remarks/>
    public arfolyamDeviza deviza
    {
        get
        {
            return this.devizaField;
        }
        set
        {
            this.devizaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class arfolyamValuta
{

    private arfolyamValutaItem itemField;

    /// <remarks/>
    public arfolyamValutaItem item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class arfolyamValutaItem
{

    private string bankField;

    private string datumField;

    private string penznemField;

    private string vetelField;

    private string eladasField;

    /// <remarks/>
    public string bank
    {
        get
        {
            return this.bankField;
        }
        set
        {
            this.bankField = value;
        }
    }

    /// <remarks/>
    public string datum
    {
        get
        {
            return this.datumField;
        }
        set
        {
            this.datumField = value;
        }
    }

    /// <remarks/>
    public string penznem
    {
        get
        {
            return this.penznemField;
        }
        set
        {
            this.penznemField = value;
        }
    }

    /// <remarks/>
    public string vetel
    {
        get
        {
            return this.vetelField;
        }
        set
        {
            this.vetelField = value;
        }
    }

    /// <remarks/>
    public string eladas
    {
        get
        {
            return this.eladasField;
        }
        set
        {
            this.eladasField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class arfolyamDeviza
{

    private arfolyamDevizaItem itemField;

    /// <remarks/>
    public arfolyamDevizaItem item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class arfolyamDevizaItem
{

    private string bankField;

    private string datumField;

    private string penznemField;

    private string vetelField;

    private string eladasField;

    private string kozepField;

    private string[] textField;

    /// <remarks/>
    public string bank
    {
        get
        {
            return this.bankField;
        }
        set
        {
            this.bankField = value;
        }
    }

    /// <remarks/>
    public string datum
    {
        get
        {
            return this.datumField;
        }
        set
        {
            this.datumField = value;
        }
    }

    /// <remarks/>
    public string penznem
    {
        get
        {
            return this.penznemField;
        }
        set
        {
            this.penznemField = value;
        }
    }

    /// <remarks/>
    public string vetel
    {
        get
        {
            return this.vetelField;
        }
        set
        {
            this.vetelField = value;
        }
    }

    /// <remarks/>
    public string eladas
    {
        get
        {
            return this.eladasField;
        }
        set
        {
            this.eladasField = value;
        }
    }

    /// <remarks/>
    public string kozep
    {
        get
        {
            return this.kozepField;
        }
        set
        {
            this.kozepField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] Text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }
}


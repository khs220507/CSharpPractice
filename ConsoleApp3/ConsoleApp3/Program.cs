class Hardware { }

class USB
{
    string name;
    public USB(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return name;
    }
}

class Notebook : Hardware, IEnumerable
{
    USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2E") };
    public IEnumerator GetEnumerator() 
    {
        return new USBEnumerator(usbList);
    }
}
using System;
using System.Collections;

public class CssObject
{
    public string ObjectId { get; set; }
    public Hashtable Style { get; set; }
    public string StyleHtml { get; set; }

    public CssObject(string oid)
    {
        ObjectId = oid;
        Style = new Hashtable();
    }

    public void UpdateStyle(string key, string value)
    {
        Style.Add(key, value);
    }

    public string OutPutStyle()
    {
        var html = $@".{ObjectId}{{ ";
        foreach (DictionaryEntry st in Style)
        {
            //Console.WriteLine("Key = {0}, Value = {1}", st.Key, st.Value);
            html += $@"{st.Key}: {st.Value}; ";
        }

        html += $@"}}";
        return html;
    }

}

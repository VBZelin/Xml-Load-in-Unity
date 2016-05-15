using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

[XmlRoot("ItemCollection")]
public class ItemContainer
{
    [XmlArray("Items")]
    [XmlArrayItem("Item")]
    public List<Item> items = new List<Item>();

    public static ItemContainer Load(string path)
    {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ItemContainer));
        StringReader sr = new StringReader(_xml.text);
        ItemContainer items = xmlSerializer.Deserialize(sr) as ItemContainer;
        sr.Close();
        return items;
    }
}

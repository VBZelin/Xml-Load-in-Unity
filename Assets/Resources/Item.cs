using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Item
{
    [XmlAttribute("name")]
    public string itemName;

    [XmlElement("damage")]
    public float damage;

    [XmlElement("durability")]
    public float durability;
}

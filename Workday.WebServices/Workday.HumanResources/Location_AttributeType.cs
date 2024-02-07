using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Location_AttributeType : INotifyPropertyChanged
	{
		private Location_AttributeObjectType location_Attribute_ReferenceField;

		private Location_Attribute_DataType location_Attribute_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Location_AttributeObjectType Location_Attribute_Reference
		{
			get
			{
				return this.location_Attribute_ReferenceField;
			}
			set
			{
				this.location_Attribute_ReferenceField = value;
				this.RaisePropertyChanged("Location_Attribute_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Location_Attribute_DataType Location_Attribute_Data
		{
			get
			{
				return this.location_Attribute_DataField;
			}
			set
			{
				this.location_Attribute_DataField = value;
				this.RaisePropertyChanged("Location_Attribute_Data");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Inventory_Location_Attributes_RequestType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Location_ReferenceField;

		private Inventory_Location_Attributes_WWS_Detail_DataType inventory_Location_Attributes_Detail_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Location_Reference
		{
			get
			{
				return this.inventory_Location_ReferenceField;
			}
			set
			{
				this.inventory_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Inventory_Location_Attributes_WWS_Detail_DataType Inventory_Location_Attributes_Detail_Data
		{
			get
			{
				return this.inventory_Location_Attributes_Detail_DataField;
			}
			set
			{
				this.inventory_Location_Attributes_Detail_DataField = value;
				this.RaisePropertyChanged("Inventory_Location_Attributes_Detail_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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

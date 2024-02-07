using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Manufacturer_DataType : INotifyPropertyChanged
	{
		private string manufacturer_IDField;

		private string manufacturer_Name_ReferenceField;

		private string manufacturer_URL_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Manufacturer_ID
		{
			get
			{
				return this.manufacturer_IDField;
			}
			set
			{
				this.manufacturer_IDField = value;
				this.RaisePropertyChanged("Manufacturer_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Manufacturer_Name_Reference
		{
			get
			{
				return this.manufacturer_Name_ReferenceField;
			}
			set
			{
				this.manufacturer_Name_ReferenceField = value;
				this.RaisePropertyChanged("Manufacturer_Name_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Manufacturer_URL_Reference
		{
			get
			{
				return this.manufacturer_URL_ReferenceField;
			}
			set
			{
				this.manufacturer_URL_ReferenceField = value;
				this.RaisePropertyChanged("Manufacturer_URL_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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

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
	public class Worker_Personal_DataType : INotifyPropertyChanged
	{
		private Name_DataType[] name_DataField;

		private Contact_DataType contact_DataField;

		private Biographic_DataType[] biographic_DataField;

		private Demographic_DataType[] demographic_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Name_Data", Order = 0)]
		public Name_DataType[] Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Contact_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement("Biographic_Data", Order = 2)]
		public Biographic_DataType[] Biographic_Data
		{
			get
			{
				return this.biographic_DataField;
			}
			set
			{
				this.biographic_DataField = value;
				this.RaisePropertyChanged("Biographic_Data");
			}
		}

		[XmlElement("Demographic_Data", Order = 3)]
		public Demographic_DataType[] Demographic_Data
		{
			get
			{
				return this.demographic_DataField;
			}
			set
			{
				this.demographic_DataField = value;
				this.RaisePropertyChanged("Demographic_Data");
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

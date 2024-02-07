using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Facilities_and_Admin_Cost_Rate_Type_Type_RequestType : INotifyPropertyChanged
	{
		private Facilities_and_Admin_Cost_Rate_Type_TypeObjectType facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;

		private Facilities_and_Admin_Cost_Rate_Type_Type_DataType facilities_and_Admin_Cost_Rate_Type_Type_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Facilities_and_Admin_Cost_Rate_Type_TypeObjectType Facilities_and_Admin_Cost_Rate_Type_Type_Reference
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_ReferenceField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Facilities_and_Admin_Cost_Rate_Type_Type_DataType Facilities_and_Admin_Cost_Rate_Type_Type_Data
		{
			get
			{
				return this.facilities_and_Admin_Cost_Rate_Type_Type_DataField;
			}
			set
			{
				this.facilities_and_Admin_Cost_Rate_Type_Type_DataField = value;
				this.RaisePropertyChanged("Facilities_and_Admin_Cost_Rate_Type_Type_Data");
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

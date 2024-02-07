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
	public class Put_Company_as_Business_Entity_RequestType : INotifyPropertyChanged
	{
		private Company_as_Business_EntityObjectType company_as_Business_Entity_ReferenceField;

		private Company_as_Business_Entity_DataType company_as_Business_Entity_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Company_as_Business_EntityObjectType Company_as_Business_Entity_Reference
		{
			get
			{
				return this.company_as_Business_Entity_ReferenceField;
			}
			set
			{
				this.company_as_Business_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Company_as_Business_Entity_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Company_as_Business_Entity_DataType Company_as_Business_Entity_Data
		{
			get
			{
				return this.company_as_Business_Entity_DataField;
			}
			set
			{
				this.company_as_Business_Entity_DataField = value;
				this.RaisePropertyChanged("Company_as_Business_Entity_Data");
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

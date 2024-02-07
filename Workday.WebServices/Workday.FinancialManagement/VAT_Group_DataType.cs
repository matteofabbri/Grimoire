using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class VAT_Group_DataType : INotifyPropertyChanged
	{
		private string vAT_Group_IDField;

		private string vAT_Group_NameField;

		private CountryObjectType country_ReferenceField;

		private CompanyObjectType[] company__Nonsingular__ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string VAT_Group_ID
		{
			get
			{
				return this.vAT_Group_IDField;
			}
			set
			{
				this.vAT_Group_IDField = value;
				this.RaisePropertyChanged("VAT_Group_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string VAT_Group_Name
		{
			get
			{
				return this.vAT_Group_NameField;
			}
			set
			{
				this.vAT_Group_NameField = value;
				this.RaisePropertyChanged("VAT_Group_Name");
			}
		}

		[XmlElement(Order = 2)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement("Company__Nonsingular__Reference", Order = 3)]
		public CompanyObjectType[] Company__Nonsingular__Reference
		{
			get
			{
				return this.company__Nonsingular__ReferenceField;
			}
			set
			{
				this.company__Nonsingular__ReferenceField = value;
				this.RaisePropertyChanged("Company__Nonsingular__Reference");
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

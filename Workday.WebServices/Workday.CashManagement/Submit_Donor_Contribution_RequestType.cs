using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Donor_Contribution_RequestType : INotifyPropertyChanged
	{
		private Donor_ContributionObjectType donor_Contribution_ReferenceField;

		private Financials_Business_Process_ParametersType[] business_Process_ParametersField;

		private Donor_Contribution_DataType donor_Contribution_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Donor_ContributionObjectType Donor_Contribution_Reference
		{
			get
			{
				return this.donor_Contribution_ReferenceField;
			}
			set
			{
				this.donor_Contribution_ReferenceField = value;
				this.RaisePropertyChanged("Donor_Contribution_Reference");
			}
		}

		[XmlElement("Business_Process_Parameters", Order = 1)]
		public Financials_Business_Process_ParametersType[] Business_Process_Parameters
		{
			get
			{
				return this.business_Process_ParametersField;
			}
			set
			{
				this.business_Process_ParametersField = value;
				this.RaisePropertyChanged("Business_Process_Parameters");
			}
		}

		[XmlElement(Order = 2)]
		public Donor_Contribution_DataType Donor_Contribution_Data
		{
			get
			{
				return this.donor_Contribution_DataField;
			}
			set
			{
				this.donor_Contribution_DataField = value;
				this.RaisePropertyChanged("Donor_Contribution_Data");
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

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
	public class XMLNAME_1099_Misc_Request_CriteriaType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType iRS_1099_Electronic_Filing_Run_ReferenceField;

		private CompanyObjectType[] company_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType IRS_1099_Electronic_Filing_Run_Reference
		{
			get
			{
				return this.iRS_1099_Electronic_Filing_Run_ReferenceField;
			}
			set
			{
				this.iRS_1099_Electronic_Filing_Run_ReferenceField = value;
				this.RaisePropertyChanged("IRS_1099_Electronic_Filing_Run_Reference");
			}
		}

		[XmlElement("Company_Reference", Order = 1)]
		public CompanyObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
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

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Company_Creditor_IdentifierType : INotifyPropertyChanged
	{
		private Creditor_IdentifierObjectType creditor_Identifier_ReferenceField;

		private Company_Creditor_Identifier_WS_Detail_DataType[] company_Creditor_Identifier_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Creditor_IdentifierObjectType Creditor_Identifier_Reference
		{
			get
			{
				return this.creditor_Identifier_ReferenceField;
			}
			set
			{
				this.creditor_Identifier_ReferenceField = value;
				this.RaisePropertyChanged("Creditor_Identifier_Reference");
			}
		}

		[XmlElement("Company_Creditor_Identifier_Detail_Data", Order = 1)]
		public Company_Creditor_Identifier_WS_Detail_DataType[] Company_Creditor_Identifier_Detail_Data
		{
			get
			{
				return this.company_Creditor_Identifier_Detail_DataField;
			}
			set
			{
				this.company_Creditor_Identifier_Detail_DataField = value;
				this.RaisePropertyChanged("Company_Creditor_Identifier_Detail_Data");
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

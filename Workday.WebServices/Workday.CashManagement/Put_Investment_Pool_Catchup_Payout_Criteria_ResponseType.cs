using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Put_Investment_Pool_Catch-up_Payout_Criteria_ResponseType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Investment_Pool_Catchup_Payout_Criteria_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType investment_Pool_Payout_Criteria_ReferenceField;

		private Investment_Pool_Payout_Criteria_DataType investment_Pool_Payout_CriteriaField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Investment_Pool_Payout_Criteria_Reference
		{
			get
			{
				return this.investment_Pool_Payout_Criteria_ReferenceField;
			}
			set
			{
				this.investment_Pool_Payout_Criteria_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Payout_Criteria_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Investment_Pool_Payout_Criteria_DataType Investment_Pool_Payout_Criteria
		{
			get
			{
				return this.investment_Pool_Payout_CriteriaField;
			}
			set
			{
				this.investment_Pool_Payout_CriteriaField = value;
				this.RaisePropertyChanged("Investment_Pool_Payout_Criteria");
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

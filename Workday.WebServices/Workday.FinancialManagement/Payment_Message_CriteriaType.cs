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
	public class Payment_Message_CriteriaType : INotifyPropertyChanged
	{
		private Payment_MessageObjectType payment_Message_ReferenceField;

		private string payment_Message_GroupField;

		private Payment_StatusObjectType[] exclude_Payment_Statuses_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_MessageObjectType Payment_Message_Reference
		{
			get
			{
				return this.payment_Message_ReferenceField;
			}
			set
			{
				this.payment_Message_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Message_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Payment_Message_Group
		{
			get
			{
				return this.payment_Message_GroupField;
			}
			set
			{
				this.payment_Message_GroupField = value;
				this.RaisePropertyChanged("Payment_Message_Group");
			}
		}

		[XmlElement("Exclude_Payment_Statuses_Reference", Order = 2)]
		public Payment_StatusObjectType[] Exclude_Payment_Statuses_Reference
		{
			get
			{
				return this.exclude_Payment_Statuses_ReferenceField;
			}
			set
			{
				this.exclude_Payment_Statuses_ReferenceField = value;
				this.RaisePropertyChanged("Exclude_Payment_Statuses_Reference");
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

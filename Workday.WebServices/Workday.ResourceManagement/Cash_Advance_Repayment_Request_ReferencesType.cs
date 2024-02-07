using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Cash_Advance_Repayment_Request_ReferencesType : INotifyPropertyChanged
	{
		private Cash_Advance_RepaymentObjectType[] cash_Advance_Repayment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Cash_Advance_Repayment_Reference", Order = 0)]
		public Cash_Advance_RepaymentObjectType[] Cash_Advance_Repayment_Reference
		{
			get
			{
				return this.cash_Advance_Repayment_ReferenceField;
			}
			set
			{
				this.cash_Advance_Repayment_ReferenceField = value;
				this.RaisePropertyChanged("Cash_Advance_Repayment_Reference");
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

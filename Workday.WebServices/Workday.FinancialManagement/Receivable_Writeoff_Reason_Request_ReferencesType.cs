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
	public class Receivable_Writeoff_Reason_Request_ReferencesType : INotifyPropertyChanged
	{
		private Receivable_Writeoff_ReasonObjectType[] receivable_Writeoff_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Receivable_Writeoff_Category_Reference", Order = 0)]
		public Receivable_Writeoff_ReasonObjectType[] Receivable_Writeoff_Category_Reference
		{
			get
			{
				return this.receivable_Writeoff_Category_ReferenceField;
			}
			set
			{
				this.receivable_Writeoff_Category_ReferenceField = value;
				this.RaisePropertyChanged("Receivable_Writeoff_Category_Reference");
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

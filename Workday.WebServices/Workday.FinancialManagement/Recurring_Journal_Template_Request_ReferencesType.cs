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
	public class Recurring_Journal_Template_Request_ReferencesType : INotifyPropertyChanged
	{
		private Recurring_Journal_TemplateObjectType[] recurring_Journal_Template_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Recurring_Journal_Template_Reference", Order = 0)]
		public Recurring_Journal_TemplateObjectType[] Recurring_Journal_Template_Reference
		{
			get
			{
				return this.recurring_Journal_Template_ReferenceField;
			}
			set
			{
				this.recurring_Journal_Template_ReferenceField = value;
				this.RaisePropertyChanged("Recurring_Journal_Template_Reference");
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

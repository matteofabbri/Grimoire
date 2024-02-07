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
	public class Custom_Validation_Rule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Custom_Validation_ContextObjectType[] custom_Validation_Context_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Custom_Validation_Context_Reference", Order = 0)]
		public Custom_Validation_ContextObjectType[] Custom_Validation_Context_Reference
		{
			get
			{
				return this.custom_Validation_Context_ReferenceField;
			}
			set
			{
				this.custom_Validation_Context_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Validation_Context_Reference");
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

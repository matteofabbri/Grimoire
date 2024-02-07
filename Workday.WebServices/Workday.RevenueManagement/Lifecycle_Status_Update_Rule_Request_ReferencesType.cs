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
	public class Lifecycle_Status_Update_Rule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Lifecycle_Status_Update_RuleObjectType[] lifecycle_Status_Update_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Lifecycle_Status_Update_Rule_Reference", Order = 0)]
		public Lifecycle_Status_Update_RuleObjectType[] Lifecycle_Status_Update_Rule_Reference
		{
			get
			{
				return this.lifecycle_Status_Update_Rule_ReferenceField;
			}
			set
			{
				this.lifecycle_Status_Update_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Lifecycle_Status_Update_Rule_Reference");
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

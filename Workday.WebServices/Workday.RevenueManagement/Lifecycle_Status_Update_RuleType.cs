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
	public class Lifecycle_Status_Update_RuleType : INotifyPropertyChanged
	{
		private Lifecycle_Status_Update_RuleObjectType lifecycle_Status_Update_Rule_ReferenceField;

		private Lifecycle_Status_Update_Rule_DataType[] lifecycle_Status_Update_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Lifecycle_Status_Update_RuleObjectType Lifecycle_Status_Update_Rule_Reference
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

		[XmlElement("Lifecycle_Status_Update_Rule_Data", Order = 1)]
		public Lifecycle_Status_Update_Rule_DataType[] Lifecycle_Status_Update_Rule_Data
		{
			get
			{
				return this.lifecycle_Status_Update_Rule_DataField;
			}
			set
			{
				this.lifecycle_Status_Update_Rule_DataField = value;
				this.RaisePropertyChanged("Lifecycle_Status_Update_Rule_Data");
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

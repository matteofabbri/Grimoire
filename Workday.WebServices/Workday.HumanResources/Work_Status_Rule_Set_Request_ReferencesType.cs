using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Work_Status_Rule_Set_Request_ReferencesType : INotifyPropertyChanged
	{
		private Work_Status_Rule_SetObjectType[] work_Status_Rule_Set_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Work_Status_Rule_Set_Reference", Order = 0)]
		public Work_Status_Rule_SetObjectType[] Work_Status_Rule_Set_Reference
		{
			get
			{
				return this.work_Status_Rule_Set_ReferenceField;
			}
			set
			{
				this.work_Status_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Set_Reference");
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

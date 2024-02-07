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
	public class Work_Status_Rule_SetType : INotifyPropertyChanged
	{
		private Work_Status_Rule_SetObjectType work_Status_Rule_Set_ReferenceField;

		private Work_Status_Rule_Set_DataType[] work_Status_Rule_Set_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Work_Status_Rule_SetObjectType Work_Status_Rule_Set_Reference
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

		[XmlElement("Work_Status_Rule_Set_Data", Order = 1)]
		public Work_Status_Rule_Set_DataType[] Work_Status_Rule_Set_Data
		{
			get
			{
				return this.work_Status_Rule_Set_DataField;
			}
			set
			{
				this.work_Status_Rule_Set_DataField = value;
				this.RaisePropertyChanged("Work_Status_Rule_Set_Data");
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

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
	public class Custom_Validation_DataType : INotifyPropertyChanged
	{
		private Condition_Rule_Data_WWSType condition_Rule_DataField;

		private Notification_Message_Component_DataType[] validation_Message_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_Rule_Data_WWSType Condition_Rule_Data
		{
			get
			{
				return this.condition_Rule_DataField;
			}
			set
			{
				this.condition_Rule_DataField = value;
				this.RaisePropertyChanged("Condition_Rule_Data");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Message_Component_Data", IsNullable = false)]
		public Notification_Message_Component_DataType[] Validation_Message_Data
		{
			get
			{
				return this.validation_Message_DataField;
			}
			set
			{
				this.validation_Message_DataField = value;
				this.RaisePropertyChanged("Validation_Message_Data");
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

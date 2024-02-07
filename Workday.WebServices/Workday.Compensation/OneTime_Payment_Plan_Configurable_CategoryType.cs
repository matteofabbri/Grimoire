using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "One-Time_Payment_Plan_Configurable_CategoryType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class OneTime_Payment_Plan_Configurable_CategoryType : INotifyPropertyChanged
	{
		private OneTime_Payment_Plan_Configurable_CategoryObjectType oneTime_Payment_Plan_Configurable_Category_ReferenceField;

		private OneTime_Payment_Plan_Configurable_Category_DataType oneTime_Payment_Plan_Configurable_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("One-Time_Payment_Plan_Configurable_Category_Reference", Order = 0)]
		public OneTime_Payment_Plan_Configurable_CategoryObjectType OneTime_Payment_Plan_Configurable_Category_Reference
		{
			get
			{
				return this.oneTime_Payment_Plan_Configurable_Category_ReferenceField;
			}
			set
			{
				this.oneTime_Payment_Plan_Configurable_Category_ReferenceField = value;
				this.RaisePropertyChanged("OneTime_Payment_Plan_Configurable_Category_Reference");
			}
		}

		[XmlElement("One-Time_Payment_Plan_Configurable_Category_Data", Order = 1)]
		public OneTime_Payment_Plan_Configurable_Category_DataType OneTime_Payment_Plan_Configurable_Category_Data
		{
			get
			{
				return this.oneTime_Payment_Plan_Configurable_Category_DataField;
			}
			set
			{
				this.oneTime_Payment_Plan_Configurable_Category_DataField = value;
				this.RaisePropertyChanged("OneTime_Payment_Plan_Configurable_Category_Data");
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

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
	public class Lifecycle_Status_Update_Rule_Award_Task_Criteria_DataType : INotifyPropertyChanged
	{
		private Lifecycle_Status_Update_Rule_Award_Task_CriteriaObjectType update_Rule_Award_Task_Criteria_ReferenceField;

		private string update_Rule_Award_Task_Criteria_IDField;

		private Award_Task_TypeObjectType award_Task_Type_ReferenceField;

		private Award_Task_StatusObjectType[] award_Task_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Lifecycle_Status_Update_Rule_Award_Task_CriteriaObjectType Update_Rule_Award_Task_Criteria_Reference
		{
			get
			{
				return this.update_Rule_Award_Task_Criteria_ReferenceField;
			}
			set
			{
				this.update_Rule_Award_Task_Criteria_ReferenceField = value;
				this.RaisePropertyChanged("Update_Rule_Award_Task_Criteria_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Update_Rule_Award_Task_Criteria_ID
		{
			get
			{
				return this.update_Rule_Award_Task_Criteria_IDField;
			}
			set
			{
				this.update_Rule_Award_Task_Criteria_IDField = value;
				this.RaisePropertyChanged("Update_Rule_Award_Task_Criteria_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Award_Task_TypeObjectType Award_Task_Type_Reference
		{
			get
			{
				return this.award_Task_Type_ReferenceField;
			}
			set
			{
				this.award_Task_Type_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Type_Reference");
			}
		}

		[XmlElement("Award_Task_Status_Reference", Order = 3)]
		public Award_Task_StatusObjectType[] Award_Task_Status_Reference
		{
			get
			{
				return this.award_Task_Status_ReferenceField;
			}
			set
			{
				this.award_Task_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Status_Reference");
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

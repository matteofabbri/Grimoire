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
	public class Award_Task_Type_Group_DataType : INotifyPropertyChanged
	{
		private Award_Task_Type_GroupObjectType award_Task_Type_Group_ReferenceField;

		private string award_Task_Type_Group_Reference_IDField;

		private string award_Task_Type_Group_NameField;

		private Award_Task_Type_DataType[] award_Task_Type_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_Task_Type_GroupObjectType Award_Task_Type_Group_Reference
		{
			get
			{
				return this.award_Task_Type_Group_ReferenceField;
			}
			set
			{
				this.award_Task_Type_Group_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Type_Group_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Award_Task_Type_Group_Reference_ID
		{
			get
			{
				return this.award_Task_Type_Group_Reference_IDField;
			}
			set
			{
				this.award_Task_Type_Group_Reference_IDField = value;
				this.RaisePropertyChanged("Award_Task_Type_Group_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Award_Task_Type_Group_Name
		{
			get
			{
				return this.award_Task_Type_Group_NameField;
			}
			set
			{
				this.award_Task_Type_Group_NameField = value;
				this.RaisePropertyChanged("Award_Task_Type_Group_Name");
			}
		}

		[XmlElement("Award_Task_Type_Data", Order = 3)]
		public Award_Task_Type_DataType[] Award_Task_Type_Data
		{
			get
			{
				return this.award_Task_Type_DataField;
			}
			set
			{
				this.award_Task_Type_DataField = value;
				this.RaisePropertyChanged("Award_Task_Type_Data");
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

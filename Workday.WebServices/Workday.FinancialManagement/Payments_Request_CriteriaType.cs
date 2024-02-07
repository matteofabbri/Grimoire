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
	public class Payments_Request_CriteriaType : INotifyPropertyChanged
	{
		private object[] itemsField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Paramenter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Check_Payments_To_Print_Criteria", typeof(Check_Payments_To_Print_CriteriaType), Order = 0), XmlElement("General_Payment_Criteria", typeof(General_Payment_CriteriaType), Order = 0), XmlElement("Payment_Message_Criteria", typeof(Payment_Message_CriteriaType), Order = 0), XmlElement("Remittance_File_Criteria", typeof(Remittance_File_CriteriaType), Order = 0)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Paramenter_Criteria_Data
		{
			get
			{
				return this.field_And_Paramenter_Criteria_DataField;
			}
			set
			{
				this.field_And_Paramenter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Paramenter_Criteria_Data");
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

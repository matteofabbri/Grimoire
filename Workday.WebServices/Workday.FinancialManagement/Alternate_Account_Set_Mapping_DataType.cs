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
	public class Alternate_Account_Set_Mapping_DataType : INotifyPropertyChanged
	{
		private string mapping_NameField;

		private string reversal_Mapping_NameField;

		private Account_SetObjectType input_Account_Set_ReferenceField;

		private Account_SetObjectType output_Account_Set_ReferenceField;

		private Account_Set_Mapping_Rule_DataType[] account_Set_Mapping_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Mapping_Name
		{
			get
			{
				return this.mapping_NameField;
			}
			set
			{
				this.mapping_NameField = value;
				this.RaisePropertyChanged("Mapping_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Reversal_Mapping_Name
		{
			get
			{
				return this.reversal_Mapping_NameField;
			}
			set
			{
				this.reversal_Mapping_NameField = value;
				this.RaisePropertyChanged("Reversal_Mapping_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Account_SetObjectType Input_Account_Set_Reference
		{
			get
			{
				return this.input_Account_Set_ReferenceField;
			}
			set
			{
				this.input_Account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Input_Account_Set_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Account_SetObjectType Output_Account_Set_Reference
		{
			get
			{
				return this.output_Account_Set_ReferenceField;
			}
			set
			{
				this.output_Account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Output_Account_Set_Reference");
			}
		}

		[XmlElement("Account_Set_Mapping_Rule_Data", Order = 4)]
		public Account_Set_Mapping_Rule_DataType[] Account_Set_Mapping_Rule_Data
		{
			get
			{
				return this.account_Set_Mapping_Rule_DataField;
			}
			set
			{
				this.account_Set_Mapping_Rule_DataField = value;
				this.RaisePropertyChanged("Account_Set_Mapping_Rule_Data");
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

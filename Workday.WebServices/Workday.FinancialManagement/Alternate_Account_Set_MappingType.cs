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
	public class Alternate_Account_Set_MappingType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType alternate_Account_Set_Mapping_ReferenceField;

		private Alternate_Account_Set_Mapping_DataType[] alternate_Account_Set_Mapping_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Alternate_Account_Set_Mapping_Reference
		{
			get
			{
				return this.alternate_Account_Set_Mapping_ReferenceField;
			}
			set
			{
				this.alternate_Account_Set_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Account_Set_Mapping_Reference");
			}
		}

		[XmlElement("Alternate_Account_Set_Mapping_Data", Order = 1)]
		public Alternate_Account_Set_Mapping_DataType[] Alternate_Account_Set_Mapping_Data
		{
			get
			{
				return this.alternate_Account_Set_Mapping_DataField;
			}
			set
			{
				this.alternate_Account_Set_Mapping_DataField = value;
				this.RaisePropertyChanged("Alternate_Account_Set_Mapping_Data");
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

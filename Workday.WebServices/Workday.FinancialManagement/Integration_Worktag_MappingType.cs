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
	public class Integration_Worktag_MappingType : INotifyPropertyChanged
	{
		private Integration_Worktag_MappingObjectType integration_Worktag_Mapping_ReferenceField;

		private Integration_Worktag_Mapping_DataType[] integration_Worktag_Mapping_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_Worktag_MappingObjectType Integration_Worktag_Mapping_Reference
		{
			get
			{
				return this.integration_Worktag_Mapping_ReferenceField;
			}
			set
			{
				this.integration_Worktag_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Worktag_Mapping_Reference");
			}
		}

		[XmlElement("Integration_Worktag_Mapping_Data", Order = 1)]
		public Integration_Worktag_Mapping_DataType[] Integration_Worktag_Mapping_Data
		{
			get
			{
				return this.integration_Worktag_Mapping_DataField;
			}
			set
			{
				this.integration_Worktag_Mapping_DataField = value;
				this.RaisePropertyChanged("Integration_Worktag_Mapping_Data");
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

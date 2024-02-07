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
	public class Fund_HierarchyType : INotifyPropertyChanged
	{
		private Fund_HierarchyObjectType fund_Hierarchy_ReferenceField;

		private Fund_Hierarchy_DataType[] fund_Hierarchy_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Fund_HierarchyObjectType Fund_Hierarchy_Reference
		{
			get
			{
				return this.fund_Hierarchy_ReferenceField;
			}
			set
			{
				this.fund_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Fund_Hierarchy_Reference");
			}
		}

		[XmlElement("Fund_Hierarchy_Data", Order = 1)]
		public Fund_Hierarchy_DataType[] Fund_Hierarchy_Data
		{
			get
			{
				return this.fund_Hierarchy_DataField;
			}
			set
			{
				this.fund_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Fund_Hierarchy_Data");
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

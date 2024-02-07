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
	public class Grant_HierarchyType : INotifyPropertyChanged
	{
		private Grant_HierarchyObjectType grant_Hierarchy_ReferenceField;

		private Grant_Hierarchy_DataType[] grant_Hierarchy_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Grant_HierarchyObjectType Grant_Hierarchy_Reference
		{
			get
			{
				return this.grant_Hierarchy_ReferenceField;
			}
			set
			{
				this.grant_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Hierarchy_Reference");
			}
		}

		[XmlElement("Grant_Hierarchy_Data", Order = 1)]
		public Grant_Hierarchy_DataType[] Grant_Hierarchy_Data
		{
			get
			{
				return this.grant_Hierarchy_DataField;
			}
			set
			{
				this.grant_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Grant_Hierarchy_Data");
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

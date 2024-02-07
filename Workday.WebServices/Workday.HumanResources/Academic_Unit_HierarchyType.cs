using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Unit_HierarchyType : INotifyPropertyChanged
	{
		private Academic_Unit_HierarchyObjectType academic_Unit_Hierarchy_ReferenceField;

		private Academic_Unit_Hierarchy_DataType[] academic_Unit_Hierarchy_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_Unit_HierarchyObjectType Academic_Unit_Hierarchy_Reference
		{
			get
			{
				return this.academic_Unit_Hierarchy_ReferenceField;
			}
			set
			{
				this.academic_Unit_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Hierarchy_Reference");
			}
		}

		[XmlElement("Academic_Unit_Hierarchy_Data", Order = 1)]
		public Academic_Unit_Hierarchy_DataType[] Academic_Unit_Hierarchy_Data
		{
			get
			{
				return this.academic_Unit_Hierarchy_DataField;
			}
			set
			{
				this.academic_Unit_Hierarchy_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Hierarchy_Data");
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

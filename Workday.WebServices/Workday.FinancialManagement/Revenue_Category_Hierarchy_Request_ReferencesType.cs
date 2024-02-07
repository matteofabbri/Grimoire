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
	public class Revenue_Category_Hierarchy_Request_ReferencesType : INotifyPropertyChanged
	{
		private Revenue_Category_HierarchyObjectType[] revenue_Category_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Revenue_Category_Hierarchy_Reference", Order = 0)]
		public Revenue_Category_HierarchyObjectType[] Revenue_Category_Hierarchy_Reference
		{
			get
			{
				return this.revenue_Category_Hierarchy_ReferenceField;
			}
			set
			{
				this.revenue_Category_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Hierarchy_Reference");
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

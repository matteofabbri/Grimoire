using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Spend_Category_Hierarchy_Request_ReferencesType : INotifyPropertyChanged
	{
		private Spend_Category_HierarchyObjectType[] spend_Category_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Spend_Category_Hierarchy_Reference", Order = 0)]
		public Spend_Category_HierarchyObjectType[] Spend_Category_Hierarchy_Reference
		{
			get
			{
				return this.spend_Category_Hierarchy_ReferenceField;
			}
			set
			{
				this.spend_Category_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchy_Reference");
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

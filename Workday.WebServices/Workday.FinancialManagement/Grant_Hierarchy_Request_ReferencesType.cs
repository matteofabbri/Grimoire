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
	public class Grant_Hierarchy_Request_ReferencesType : INotifyPropertyChanged
	{
		private Grant_HierarchyObjectType[] grant_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Grant_Hierarchy_Reference", Order = 0)]
		public Grant_HierarchyObjectType[] Grant_Hierarchy_Reference
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

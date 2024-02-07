using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Structure_Request_ReferencesType : INotifyPropertyChanged
	{
		private Headcount_Plan_StructureObjectType[] headcount_Plan_Structure_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Headcount_Plan_Structure_Reference", Order = 0)]
		public Headcount_Plan_StructureObjectType[] Headcount_Plan_Structure_Reference
		{
			get
			{
				return this.headcount_Plan_Structure_ReferenceField;
			}
			set
			{
				this.headcount_Plan_Structure_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Plan_Structure_Reference");
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

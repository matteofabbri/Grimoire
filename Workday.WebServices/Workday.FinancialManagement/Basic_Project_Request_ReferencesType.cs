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
	public class Basic_Project_Request_ReferencesType : INotifyPropertyChanged
	{
		private ProjectObjectType[] basic_Project_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Basic_Project_Reference", Order = 0)]
		public ProjectObjectType[] Basic_Project_Reference
		{
			get
			{
				return this.basic_Project_ReferenceField;
			}
			set
			{
				this.basic_Project_ReferenceField = value;
				this.RaisePropertyChanged("Basic_Project_Reference");
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

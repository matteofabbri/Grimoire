using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Percent_Complete_Project_Request_CriteriaType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] as_Of_Date_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("As_Of_Date_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] As_Of_Date_Reference
		{
			get
			{
				return this.as_Of_Date_ReferenceField;
			}
			set
			{
				this.as_Of_Date_ReferenceField = value;
				this.RaisePropertyChanged("As_Of_Date_Reference");
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

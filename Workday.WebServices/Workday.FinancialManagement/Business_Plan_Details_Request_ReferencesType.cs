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
	public class Business_Plan_Details_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] business_Plan_Details_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Business_Plan_Details_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Business_Plan_Details_Reference
		{
			get
			{
				return this.business_Plan_Details_ReferenceField;
			}
			set
			{
				this.business_Plan_Details_ReferenceField = value;
				this.RaisePropertyChanged("Business_Plan_Details_Reference");
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

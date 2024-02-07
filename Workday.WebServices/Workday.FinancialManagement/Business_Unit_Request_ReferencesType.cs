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
	public class Business_Unit_Request_ReferencesType : INotifyPropertyChanged
	{
		private Business_UnitObjectType[] business_Unit_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Business_Unit_Reference", Order = 0)]
		public Business_UnitObjectType[] Business_Unit_Reference
		{
			get
			{
				return this.business_Unit_ReferenceField;
			}
			set
			{
				this.business_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Business_Unit_Reference");
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

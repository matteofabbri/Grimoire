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
	public class Spend_Restriction_Request_ReferencesType : INotifyPropertyChanged
	{
		private Spend_RestrictionObjectType[] spend_Restriction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Spend_Restriction_Reference", Order = 0)]
		public Spend_RestrictionObjectType[] Spend_Restriction_Reference
		{
			get
			{
				return this.spend_Restriction_ReferenceField;
			}
			set
			{
				this.spend_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Restriction_Reference");
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

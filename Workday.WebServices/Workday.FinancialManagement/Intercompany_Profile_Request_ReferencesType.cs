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
	public class Intercompany_Profile_Request_ReferencesType : INotifyPropertyChanged
	{
		private Intercompany_ProfileObjectType[] intercompany_Profile_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Intercompany_Profile_Reference", Order = 0)]
		public Intercompany_ProfileObjectType[] Intercompany_Profile_Reference
		{
			get
			{
				return this.intercompany_Profile_ReferenceField;
			}
			set
			{
				this.intercompany_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Intercompany_Profile_Reference");
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

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
	public class Position_Budget_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] position_Budget_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Position_Budget_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Position_Budget_Reference
		{
			get
			{
				return this.position_Budget_ReferenceField;
			}
			set
			{
				this.position_Budget_ReferenceField = value;
				this.RaisePropertyChanged("Position_Budget_Reference");
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

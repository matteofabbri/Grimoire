using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Citizenship_Status_Request_ReferencesType : INotifyPropertyChanged
	{
		private Citizenship_StatusObjectType[] citizenship_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Citizenship_Status_Reference", Order = 0)]
		public Citizenship_StatusObjectType[] Citizenship_Status_Reference
		{
			get
			{
				return this.citizenship_Status_ReferenceField;
			}
			set
			{
				this.citizenship_Status_ReferenceField = value;
				this.RaisePropertyChanged("Citizenship_Status_Reference");
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

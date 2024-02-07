using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Absence_Input_Request_ReferencesType : INotifyPropertyChanged
	{
		private Absence_InputObjectType[] absence_Input_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Absence_Input_Reference", Order = 0)]
		public Absence_InputObjectType[] Absence_Input_Reference
		{
			get
			{
				return this.absence_Input_ReferenceField;
			}
			set
			{
				this.absence_Input_ReferenceField = value;
				this.RaisePropertyChanged("Absence_Input_Reference");
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

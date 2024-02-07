using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class External_Association_Request_ReferencesType : INotifyPropertyChanged
	{
		private External_AssociationObjectType[] external_Association_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("External_Association_Reference", Order = 0)]
		public External_AssociationObjectType[] External_Association_Reference
		{
			get
			{
				return this.external_Association_ReferenceField;
			}
			set
			{
				this.external_Association_ReferenceField = value;
				this.RaisePropertyChanged("External_Association_Reference");
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

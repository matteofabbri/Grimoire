using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Connection_Type_Request_ReferencesType : INotifyPropertyChanged
	{
		private Mentor_TypeObjectType[] connection_Type_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Connection_Type_Reference", Order = 0)]
		public Mentor_TypeObjectType[] Connection_Type_Reference
		{
			get
			{
				return this.connection_Type_ReferenceField;
			}
			set
			{
				this.connection_Type_ReferenceField = value;
				this.RaisePropertyChanged("Connection_Type_Reference");
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

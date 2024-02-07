using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Canadian_Record_of_Employment_Data_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] canadian_Record_of_Employment_Data_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Canadian_Record_of_Employment_Data_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Canadian_Record_of_Employment_Data_Reference
		{
			get
			{
				return this.canadian_Record_of_Employment_Data_ReferenceField;
			}
			set
			{
				this.canadian_Record_of_Employment_Data_ReferenceField = value;
				this.RaisePropertyChanged("Canadian_Record_of_Employment_Data_Reference");
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

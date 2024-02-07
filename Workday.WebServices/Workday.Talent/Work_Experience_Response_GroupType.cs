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
	public class Work_Experience_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Work_Experience_Rating_ReferenceField;

		private bool include_Work_Experience_Rating_ReferenceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Work_Experience_Rating_Reference
		{
			get
			{
				return this.include_Work_Experience_Rating_ReferenceField;
			}
			set
			{
				this.include_Work_Experience_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Include_Work_Experience_Rating_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_Work_Experience_Rating_ReferenceSpecified
		{
			get
			{
				return this.include_Work_Experience_Rating_ReferenceFieldSpecified;
			}
			set
			{
				this.include_Work_Experience_Rating_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_Work_Experience_Rating_ReferenceSpecified");
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

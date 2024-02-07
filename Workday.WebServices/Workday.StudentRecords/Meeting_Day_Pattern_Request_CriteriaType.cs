using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Meeting_Day_Pattern_Request_CriteriaType : INotifyPropertyChanged
	{
		private Day_of_the_WeekObjectType[] meets_Days_of_the_Week_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Meets_Days_of_the_Week_Reference", Order = 0)]
		public Day_of_the_WeekObjectType[] Meets_Days_of_the_Week_Reference
		{
			get
			{
				return this.meets_Days_of_the_Week_ReferenceField;
			}
			set
			{
				this.meets_Days_of_the_Week_ReferenceField = value;
				this.RaisePropertyChanged("Meets_Days_of_the_Week_Reference");
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

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Academic_Rank_Request_ReferencesType : INotifyPropertyChanged
	{
		private Academic_RankObjectType[] academic_Rank_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Academic_Rank_Reference", Order = 0)]
		public Academic_RankObjectType[] Academic_Rank_Reference
		{
			get
			{
				return this.academic_Rank_ReferenceField;
			}
			set
			{
				this.academic_Rank_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Rank_Reference");
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

using System;
using System.Collections.Generic;
using System.Text;

using Serilog;
using Serilog.Events;
using AgLogManager;

namespace OpenNetLinkApp.Models.SGConfig

{
    public enum CLIPALM_TYPE : int
    {
        OSUI = 0,
        OS = 1,
        UI = 2,
    }
    public enum HOTKEY_MOD: int
    {
        // 클립보드 단축키 정보 (Win,Ctrl,Alt,Shift,Alphabet).
        WINDOW = 0,
        CTRL = 1,
        ALT = 2,
        SHIFT = 3,
        VKEY = 4,
    }

    public interface ISGAppConfig
    {
        List<string> ClipBoardHotKey { get; }       // 클립보드 단축키 정보 (Win,Ctrl,Alt,Shift,Alphabet).
        CLIPALM_TYPE enClipAlarmType { get; }       // 클립보드 알림 형식  ( 0 : OS & UI , 1 : OS, 2 : UI )
        bool bClipAfterSend { get; }                // 클립보드 복사 후 전송 기능 사용 유무 ( true : 사용, false : 미사용 )
        bool bURLAutoTrans { get; }                 // URL 자동전환 사용 유무 ( true : 사용, false : 미사용 )
        bool bURLAutoAfterMsg { get; }              // URL 자동전환 후 사용자 알림 메시지 사용 여부( true : 사용, false : 미사용 )
        string strURLAutoAfterBrowser { get; }        // URL 자동전환 후 브라우저 창 처리방식 ( C : 닫기, N : 유지, F : 특정 URL 포워딩 )
        bool bRMouseFileAddAfterTrans { get; }      // 마우스 우클릭 파일 추가 후 자동전송 사용 여부 ( true : 사용, false : 미사용 )
        bool bAfterBasicChk { get; }                // 사후 결재 체크 기본 사용 유무 ( true : 체크, false : 체크 안함 )

        List<string> RecvDownPath { get; }          // 파일 수신 경로 정보
        bool bFileRecvFolderOpen { get; }           // 파일 수신 후 폴더 자동 열기 ( true : 열기, flase : 열지 않음 )
        bool bRecvDownPathChange { get; }           // 파일 수신 경로 변경 가능 여부 ( true : 가능, false : 불가능 )
        bool bManualRecvDownChange { get; }         // 수동다운로드 사용 시 수신 폴더 변경 기능 ( true : 사용, false : 미사용)
        bool bFileRecvTrayFix { get; }              // 파일 수신 알림 트레이 유지 여부 ( true : 유지, false : 유지 안함 )
        bool bApprTrayFix { get; }                  // 결재자 승인대기 알림 트레이 유지 여부 ( true : 유지, false : 유지 안함 )
        bool bUserApprActionTrayFix { get; }        // 사용자 승인완료 알림 트레이 유지 여부 ( true : 유지, false : 유지 안함 )
        bool bUserApprRejectTrayFix { get; }        // 사용자 반려 알림 트레이 유지 여부 ( true : 유지, false : 유지 안함 )
        bool bExitTrayMove { get; }                 // 종료 시 트레이 이동 ( true : 트레이 이동, false : 종료 )
        bool bStartTrayMove { get; }                // 시작 시 트레이 이동 ( true : 트레이 이동, false : 종료 )
        bool bStartProgramReg { get; }              // 시작 프로그램 등록 ( true : 시작프로그램 등록, false : 시작프로그램 등록 해제 )
        string strLanguage { get; }                 // 다국어 지원 ( KR : 한국어, JP : 일본어, EN : 영어, CN : 중국어 )

        //bool bUseScreenLock { get; }                // 화면잠금 사용 여부.
        bool bScreenLock { get; }                   // 화면잠금 사용 여부.(체크)
        int  tScreenTime { get; }                   // 화면잠금 시간 설정( 단위 : 분 )
        string LastUpdated { get; }                 // 마지막으로 업데이트된 날짜/시간정보
        string SWVersion { get; }                   // 소프트웨어 버전 정보
        string SWCommitId { get; }                  // 소프트웨어 버전 정보 : Git Commit Point for this Released S/W
        LogEventLevel   LogLevel { get; }           // 로그레벨
        bool bUseApprWaitNoti { get; }              // 승인대기 알림 사용 여부.(체크)
        string UpdateSvcIP { get; }                 // 업데이트 서버 IP
        string UpdatePlatform { get; }              // 업데이트 될 OpenNetLinkApp Machine Architecture 플랫폼
    }
}
